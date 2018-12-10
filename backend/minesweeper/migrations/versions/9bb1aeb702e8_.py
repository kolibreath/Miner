"""empty message

Revision ID: 9bb1aeb702e8
Revises: 54a4972dc3c6
Create Date: 2018-12-10 16:50:43.680739

"""
from alembic import op
import sqlalchemy as sa
from sqlalchemy.dialects import mysql

# revision identifiers, used by Alembic.
revision = '9bb1aeb702e8'
down_revision = '54a4972dc3c6'
branch_labels = None
depends_on = None


def upgrade():
    # ### commands auto generated by Alembic - please adjust! ###
    op.add_column('users', sa.Column('challenge_map', sa.Text(), nullable=True))
    op.drop_column('users', 'challeng_map')
    # ### end Alembic commands ###


def downgrade():
    # ### commands auto generated by Alembic - please adjust! ###
    op.add_column('users', sa.Column('challeng_map', mysql.TEXT(), nullable=True))
    op.drop_column('users', 'challenge_map')
    # ### end Alembic commands ###